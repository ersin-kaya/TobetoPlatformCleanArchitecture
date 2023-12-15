﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class AccountCourse : Entity<int>
{
    public int CourseId { get; set; }
    public int AccountId { get; set; }


    public AccountCourse()
    {
        
    }

    public AccountCourse(int courseId, int accountId) : this()
    {
        CourseId = courseId;
        AccountId = accountId;
    }
}
