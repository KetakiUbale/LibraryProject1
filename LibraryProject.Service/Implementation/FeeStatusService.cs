using LibraryProject.Model;
using LibraryProject.Persistence;
using LibraryProject.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.Service
{
    public class FeeStatusService : IFeeStatusService
    {
        private readonly IUnitOfWork _unitOfWork;
        public FeeStatusService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public FeeStatus AddFeeStatus(FeeStatus feestatus)
        {
            this._unitOfWork.FeeStatusRepository.Add(feestatus);
            this._unitOfWork.Save();

            return feestatus;
        }

        public bool DeleteFeeStatus(int feestatusId)
        {
            FeeStatus feestatus = this._unitOfWork.FeeStatusRepository.GetById(feestatusId);
            if (feestatus != null)
            {
                this._unitOfWork.FeeStatusRepository.Remove(feestatus);
                this._unitOfWork.Save();

                return true;
            }
            return false;
        }



        public IEnumerable<FeeStatus> GetAllFeeStatus()
        {
            return this._unitOfWork.FeeStatusRepository.GetAll();

        }

        public FeeStatus GetById(int id)
        {
            return this._unitOfWork.FeeStatusRepository.GetById(id);
        }

        public FeeStatus UpdateFeeStatus(FeeStatus feestatus)
        {
            this._unitOfWork.FeeStatusRepository.Update(feestatus);
            this._unitOfWork.Save();

            return feestatus;
        }
    }
}