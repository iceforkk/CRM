﻿
using SIM.Domain.Entity.SystemSecurity;
using System.Data.Entity.ModelConfiguration;

namespace SIM.Mapping.SystemSecurity
{
    public class LogMap : EntityTypeConfiguration<LogEntity>
    {
        public LogMap()
        {
            this.ToTable("Sys_Log");
            this.HasKey(t => t.F_Id);
        }
    }
}
