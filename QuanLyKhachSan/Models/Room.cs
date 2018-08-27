using System;
using System.Collections.Generic;

namespace QuanLyKhachSan.Models
{
    public partial class Room
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public string Genre { get; set; }
        public double? Price { get; set; }
    }
}
