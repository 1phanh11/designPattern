using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    public interface ReportDAO<T>
    {
        public void createReportDetail(string RPid, string Rid, string Bid, string status);

        public void createReport(string RPid);
    }
}
