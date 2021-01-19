using LibraryProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.Service
{
    public interface IFeeStatusService
    {
        IEnumerable<FeeStatus> GetAllFeeStatus();
        FeeStatus GetById(int id);
    
        FeeStatus AddFeeStatus(FeeStatus feestatus);
        FeeStatus UpdateFeeStatus(FeeStatus feestatus);
        bool DeleteFeeStatus(int feestatusId);


    }
}
