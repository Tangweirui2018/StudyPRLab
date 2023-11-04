using ConsoleAppTEST;
using GitHubInfoUpdate.Objects;
using System;
using System.Reflection;

namespace GitHubInfoUpdate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private Functions func;

        private List<List<Release>?> monitors;
        Config? config;

        bool _addMode = true;


        bool _static;
        private void SetProgress(bool type)
        {
            progressBar1.Style = type ? ProgressBarStyle.Marquee : ProgressBarStyle.Blocks;
            monitorListView.Enabled = releaseListView.Enabled = silenceBox.Enabled =
                ownerBox.Enabled = repoBox.Enabled = monitorButton.Enabled = !type;
            if (type)
            {
                _static = deleteButton.Enabled;
                deleteButton.Enabled = false;
            }
            else
                deleteButton.Enabled = _static;
        }

        private async Task UpdateRelease()
        {
            if (config!.ReleaseInfo!.Count == 0)
            {
                Console.WriteLine(config!.ReleaseInfo!.Count);
                return;
            }
            SetProgress(true);

            monitors = new();

            monitorListView.BeginUpdate();
            /*
            for (int i = 0; i < config!.ReleaseInfo!.Count; i++)
            {
                (var repo, var owner, var date, var tag, var slience) = config.ReleaseInfo[i].ToTuple();

                var tmp = await func.GetRelease($"https://api.github.com/repos/{owner}/{repo}/releases");
                monitors.Add(tmp);
                if (tmp?.Count > 0)
                {
                    ListViewItem item = new();
                    item.Text = repo;
                    item.SubItems.Add(owner);
                    item.SubItems.Add(monitors[i]![0].PublishTime.ToString());
                    item.SubItems.Add(monitors[i]![0].Name);
                    if (!slience)
                    {
                        if (date == null || monitors[i]![0].PublishTime > date || !monitors[i]![0].TagName!.Equals(tag))
                        {
                            item.BackColor = Color.FromArgb(0xB0F9A4);
                        }
                    }
                    monitorListView.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new();
                    item.Text = repo;
                    item.SubItems.Add(owner);
                    item.SubItems.Add("Failed to load");
                    item.SubItems.Add("Failed to load");
                    item.BackColor = Color.FromArgb(0xFF7F48);
                    monitorListView.Items.Add(item);
                }
            }*/

            var count = config!.ReleaseInfo!.Count;

            List<Release>?[] tmpMonitors = new List<Release>?[count];
            ListViewItem[] tmpItems = new ListViewItem[count];
            Task[] tasks = new Task[count];
            bool[] finish = new bool[count];

            for (int i = 0; i < count; i++)
            {
                int index = i;
                tasks[index] = new(async () =>
                {
                    (var repo, var owner, var date, var tag, var slience) = config.ReleaseInfo[index].ToTuple();

                    var tmp = await func.GetRelease($"https://api.github.com/repos/{owner}/{repo}/releases");
                    //monitors.Add(tmp);
                    tmpMonitors[index] = tmp;
                    if (tmp?.Count > 0)
                    {
                        ListViewItem item = new();
                        var monitor = tmp[0];
                        item.Text = repo;
                        item.SubItems.Add(owner);
                        item.SubItems.Add(monitor.PublishTime.ToString());
                        item.SubItems.Add(monitor.Name);
                        if (!slience)
                            if (date == null || monitor.PublishTime > date || !monitor.TagName!.Equals(tag))
                                item.BackColor = Color.FromArgb(0xB0F9A4);
                            
                        tmpItems[index] = item;
                    }
                    else
                    {
                        ListViewItem item = new() { Text = repo };
                        item.SubItems.Add(owner);
                        item.SubItems.Add("Failed to load");
                        item.SubItems.Add("Failed to load");
                        item.BackColor = Color.FromArgb(0xFF7F48);
                        tmpItems[index] = item;
                    }
                    finish[index] = true;
                });
                tasks[index].Start();
            }

            Judge:
            for(int i = 0; i < count; i++)
            {
                if(finish[i] == false)
                {
                    Thread.Sleep(100);
                    goto Judge;
                }
            }


            
            monitors.AddRange(tmpMonitors);
            monitorListView.Items.AddRange(tmpItems);



            monitorListView.EndUpdate();

            SetProgress(false);
        }

        private void ClearReleaseInfo()
        {
            urlBox.Text = tagBox.Text = nameBox.Text = createTimeBox.Text = publishTimeBox.Text = bodyBox.Text = string.Empty;
            prereleaseCheckBox.Checked = false;
        }

        private void ClearReleaseList()
        {
            releaseListView.Items.Clear();
            setVerButton.Enabled = false;
            nowDateBox.Text = nowTagBox.Text = string.Empty;
            silenceBox.Checked = false;
            ClearReleaseInfo();
        }

        private void ClearMonitorList()
        {
            monitorListView.Items.Clear();

            monitorButton.Text = "Add";
            silenceBox.Enabled = deleteButton.Enabled = false;
            _addMode = true;
            ownerBox.Text = repoBox.Text = "";

            ClearReleaseList();
        }



        private async void Form1_Load(object sender, EventArgs e)
        {
            deleteButton.Enabled = silenceBox.Enabled = setVerButton.Enabled = false;


            func = new Functions();

            monitorListView.MultiSelect = false;
            monitorListView.View = View.Details;
            monitorListView.Columns.Add("Repo", 180, HorizontalAlignment.Left);
            monitorListView.Columns.Add("Owner", 180, HorizontalAlignment.Left);
            monitorListView.Columns.Add("Publish Time", 160, HorizontalAlignment.Left);
            monitorListView.Columns.Add("Release Name", 380, HorizontalAlignment.Left);


            releaseListView.MultiSelect = false;
            releaseListView.View = View.Details;
            releaseListView.Columns.Add("Tag", 100, HorizontalAlignment.Left);
            releaseListView.Columns.Add("Release Name", 300, HorizontalAlignment.Left);

            config = Functions.ReadConfig("./repo.json");

            await UpdateRelease();


        }

        private void releaseListView_SelectedIndexChanged(object sender, EventArgs e)
        {

            var select = releaseListView.SelectedIndices;
            if (select.Count == 1)
            {
                var index = monitorListView.SelectedIndices[0];

                var tmp = monitors[index]![select[0]];

                prereleaseCheckBox.Checked = tmp.Prerelease;
                urlBox.Text = tmp.HtmlUrl;
                tagBox.Text = tmp.TagName;
                nameBox.Text = tmp.Name;
                createTimeBox.Text = tmp.CreateTime.ToString();
                publishTimeBox.Text = tmp.PublishTime.ToString();
                bodyBox.Text = tmp.Body;

                setVerButton.Enabled = true;

                return;
            }

            setVerButton.Enabled = false;
        }

        private void monitorListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearReleaseList();


            var select = monitorListView.SelectedIndices;
            if (select.Count == 1)
            {
                var index = select[0];
                var tmp = monitors[index];
                if (tmp?.Count > 0)
                {
                    for (int i = 0; i < tmp.Count; i++)
                    {
                        var release = tmp[i];
                        ListViewItem item = new();
                        item.Text = release.TagName;
                        item.SubItems.Add(release.Name);
                        releaseListView.Items.Add(item);
                    }
                }

                nowTagBox.Text = config!.ReleaseInfo![index].InstalledTag;
                nowDateBox.Text = config!.ReleaseInfo![index].InstalledDate.ToString();
                silenceBox.Checked = config!.ReleaseInfo![index].Silence;

                monitorButton.Text = "Edit";
                silenceBox.Enabled = deleteButton.Enabled = true;
                _addMode = false;
                ownerBox.Text = config!.ReleaseInfo![index].Owner;
                repoBox.Text = config!.ReleaseInfo![index].Repo;
                return;
            }


            silenceBox.Checked = false;
            monitorButton.Text = "Add";
            silenceBox.Enabled = deleteButton.Enabled = false;
            _addMode = true;
            ownerBox.Text = repoBox.Text = "";
        }

        private async void monitorButton_Click(object sender, EventArgs e)
        {
            if (_addMode)
            {
                if (ownerBox.Text != string.Empty && repoBox.Text != string.Empty)
                {
                    config!.ReleaseInfo!.Add(new()
                    {
                        Repo = repoBox.Text,
                        Owner = ownerBox.Text,
                        InstalledDate = null,
                        Silence = false
                    });
                    ClearMonitorList();
                    await UpdateRelease();
                    var res = Functions.SaveConfig(config, "./repo.json");
                    if (!res)
                    {
                        MessageBox.Show("Failed to save the config!");
                    }
                }
            }
            else
            {
                if (ownerBox.Text != string.Empty && repoBox.Text != string.Empty)
                {
                    var index = monitorListView.SelectedIndices[0];
                    config!.ReleaseInfo![index].Owner = ownerBox.Text;
                    config!.ReleaseInfo![index].Repo = repoBox.Text;
                    ClearMonitorList();
                    await UpdateRelease();
                    var res = Functions.SaveConfig(config, "./repo.json");
                    if (!res)
                    {
                        MessageBox.Show("Failed to save the config!");
                    }
                }
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            var select = monitorListView.SelectedIndices;
            if (select.Count == 1)
            {
                var index = select[0];
                config!.ReleaseInfo!.RemoveAt(index);
                ClearMonitorList();
                await UpdateRelease();
                var res = Functions.SaveConfig(config, "./repo.json");
                if (!res)
                {
                    MessageBox.Show("Failed to save the config!");
                }
            }
        }

        private async void silenceBox_CheckStateChanged(object sender, EventArgs e)
        {
        }

        private async void setVerButton_Click(object sender, EventArgs e)
        {
            var select0 = monitorListView.SelectedIndices;
            var select1 = releaseListView.SelectedIndices;
            if (select0.Count == 1 && select0.Count == 1)
            {
                var index0 = select0[0];
                var index1 = select1[0];
                config!.ReleaseInfo![index0].InstalledDate = monitors[index0]![index1].PublishTime;
                config!.ReleaseInfo![index0].InstalledTag = monitors[index0]![index1].TagName;
                ClearMonitorList();
                await UpdateRelease();
                var res = Functions.SaveConfig(config, "./repo.json");
                if (!res)
                {
                    MessageBox.Show("Failed to save the config!");
                }
            }
        }

        private async void silenceBox_Click(object sender, EventArgs e)
        {
            var select = monitorListView.SelectedIndices;
            if (select.Count == 1)
            {
                var index = select[0];
                config!.ReleaseInfo![index].Silence = silenceBox.Checked;
                ClearMonitorList();
                await UpdateRelease();
                var res = Functions.SaveConfig(config, "./repo.json");
                if (!res)
                {
                    MessageBox.Show("Failed to save the config!");
                }
            }
        }
    }
}