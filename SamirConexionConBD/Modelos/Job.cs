using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamirConexionConBD.Modelos
{
    internal class Job
    {
        private int jobId;
        private string jobTitle;
        private decimal? jobMinSalary;
        private decimal? jobMaxSalary;

        public int JobId { get { return jobId; } set { jobId = value; } }
        public string JobTitle { get {  return jobTitle; } set { jobTitle = value; } }
        public decimal? JobMinSalary { get {  return jobMinSalary; } set { jobMinSalary = value; } }
        public decimal? JobMaxSalary { get { return jobMaxSalary; } set { jobMaxSalary = value; } }

        public Job() { }

        public Job(int jobId, string jobTitle, decimal? jobMinSalary, decimal? jobMaxSalary)
        {
            JobId = jobId;
            JobTitle = jobTitle;
            JobMinSalary = jobMinSalary;
            JobMaxSalary = jobMaxSalary;
        }
        public Job(string jobTitle, decimal? jobMinSalary, decimal? jobMaxSalary)
        {
            JobTitle = jobTitle;
            JobMinSalary = jobMinSalary;
            JobMaxSalary = jobMaxSalary;
        }
    }
}
