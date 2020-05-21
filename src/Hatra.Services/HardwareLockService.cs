using Hatra.Common.GuardToolkit;
using Hatra.DataLayer.Context;
using Hatra.Entities;
using Hatra.Services.Contracts;
using Hatra.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatra.Services
{
    public class HardwareLockService : IHardwareLockService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DbSet<HardwareLock> _hardwareLock;

        public HardwareLockService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _unitOfWork.CheckArgumentIsNull(nameof(_unitOfWork));

            _hardwareLock = _unitOfWork.Set<HardwareLock>();
            _hardwareLock.CheckArgumentIsNull(nameof(_hardwareLock));
        }

        public async Task<HardwareLockResponceViewModel> InsertOrUpdateAsync(HardwareLockViewModel viewModel)
        {
            throw new NotImplementedException();
            //var entity = await _hardwareLock.FirstOrDefaultAsync(p => p.LockSerialNumber == viewModel.LockSerialNumber && p.ComputerName == viewModel.ComputerName && p.CpuSerialNumber == p.CpuSerialNumber);

            //if (entity == null)
            //{
            //    entity = new HardwareLock();
            //    entity.ExpireDate = null;
            //    entity.IsBlocked = false;
            //    _hardwareLock.Add(entity);
            //}


            //entity.ComputerName = viewModel.ComputerName;
            //entity.CpuSerialNumber = viewModel.CpuSerialNumber;
            //entity.LockSerialNumber = viewModel.LockSerialNumber;
            //entity.FinancialYearCount = viewModel.FinancialYearCount;
            //entity.CompanyCount = viewModel.CompanyCount;
            //entity.DocumentCount = viewModel.DocumentCount;
            //entity.UserCount = viewModel.UserCount;
            //entity.AndroidUserCount = viewModel.AndroidUserCount;
            //entity.CurrentVersion = viewModel.CurrentVersion;

            //if (viewModel.FinancialYears != null && viewModel.FinancialYears.Any())
            //{
            //    var currentFinancialYears = entity.FinancialYears.ToList();

            //    var newFinancialYears = viewModel.FinancialYears.Where(p => !currentFinancialYears.Any(q => q.FinancialYearId == p.FinancialYearId && q.CompanyId == p.CompanyId));
            //    var editFinancialYears = viewModel.FinancialYears.Where(p => !currentFinancialYears.Any(q => q.FinancialYearId == p.FinancialYearId && q.CompanyId == p.CompanyId));
            //    var editFinancialYears = viewModel.FinancialYears.Where(p => !currentFinancialYears.Any(q => q.FinancialYearId == p.FinancialYearId && q.CompanyId == p.CompanyId));



            //}

            //var result = await _unitOfWork.SaveChangesAsync();
            //return result != 0;
        }
    }
}
