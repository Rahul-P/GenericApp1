﻿using System;

namespace DomainCommons
{
    public class BaseDomain
    {
        
            public int Id { get; set; }

            public DateTime LastModified { get; set; }

            public string LastModifiedBy { get; set; }

            public DateTime Created { get; set; }

            public string CreatedBy { get; set; }

            public byte Rowversion { get; set; }

            public bool IsDirty { get; set; }
        
    }
}