﻿using System;
using System.Collections.Generic;

namespace designIssueExample
{
    public class EmployeeCollection
    {
        private List<Employee> _employeeCollection;

        public EmployeeCollection()
        {
            _employeeCollection = new List<Employee>();
        }

        public List<Employee> Items
        {
            get { return _employeeCollection; }
        }

        public void AddEmployeeIfMatch(Func<Employee, bool> employeeFilter, Employee employee)
        {
            if (employeeFilter(employee))
            {
                Items.Add(employee);
            }
        }
    }
}