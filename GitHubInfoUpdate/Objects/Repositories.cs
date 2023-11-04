using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubInfoUpdate.Objects
{
    class Repositories
    {
        public string? Repo { get; set; }
        public string? Owner { get; set; }
        public DateTime? InstalledDate { get; set; }
        public string? InstalledTag { get; set; }
        public bool Silence { get; set; }

        public (string? Repo, string? Owner, DateTime? InstalledDate, string? InstalledTag, bool Silence) ToTuple()
        {
            return (Repo, Owner, InstalledDate, InstalledTag, Silence);
        }
    }
}
