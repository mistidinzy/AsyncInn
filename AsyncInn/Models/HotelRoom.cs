﻿using System;
using System.Collections.Generic;

namespace Async_Inn.Models
{
    public class HotelRoom
    {
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public bool PetFriendly { get; set; }
        public bool IsHaunted { get; set; }

        public List<Hotel> Hotels { get; set; }
        public List<RoomStyle> RoomStyles { get; set; }
    }
}
