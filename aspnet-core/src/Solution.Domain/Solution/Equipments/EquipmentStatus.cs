using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Equipments
{
    /// <summary>
    /// 设备状态实体
    /// </summary>
    public class EquipmentStatus : AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }



        protected EquipmentStatus()
        {
        }

        public EquipmentStatus(
            Guid id,
            string name,
            string remark
        ) :base(id)
        {
            Name = name;
            Remark = remark;
        }
    }

}
