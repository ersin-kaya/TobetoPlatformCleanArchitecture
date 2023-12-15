﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class SurveyType : Entity<int>
{
    public string Name { get; set; }
    public bool Visibility { get; set; }

    public SurveyType()
    {
        
    }

    public SurveyType(string name, bool visibility):this()
    {
        Name = name;
        Visibility = visibility;
    }
}
