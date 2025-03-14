﻿using System.ComponentModel.DataAnnotations;

namespace _2280600021_NguyenThiVanAn_Lab03WebsiteBanHang.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
