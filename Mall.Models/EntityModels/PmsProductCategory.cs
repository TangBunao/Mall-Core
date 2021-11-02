using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall.Models.EntityModels
{
    public class PmsProductCategory
    {
        [Key]
        public int Id { get; set; }

        [Comment("上级分类的编号：0 表示一级分类")]
        public int ParentId { get; set; }

        [Column(TypeName = "varchar(64)")]
        [Comment("名称")]
        public string Name { get; set; }

        [Comment("分类级别： 0->1级；1->2级")]
        public int Level { get; set; }

        [Comment("商品数量")]
        public int ProductCount { get; set; }

        [Column(TypeName = "varchar(64)")]
        [Comment("商品单位")]
        public string ProductUnit { get; set; }

        [Comment("是否显示在导航栏：0->不显示；1->显示")]
        public int NavStatus { get; set; }

        [Comment("显示状态：0->不显示；1->显示")]
        public int ShowStatus { get; set; }

        [Comment("排序")]
        public int Sort { get; set; }

        [Column(TypeName = "varchar(255)")]
        [Comment("图标")]
        public string Icon { get; set; }

        [Column(TypeName = "varchar(255)")]
        [Comment("关键字")]
        public string Keywords { get; set; }

        [Comment("描述")]
        public string Description { get; set; }
    }
}
