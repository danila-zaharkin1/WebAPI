﻿
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICompanyRepository
    {
        public interface ICompanyRepository
        {
            public void UpdateCompany(Company company);
        }
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
        public void UpdateCompany(Company company);
    }
}
