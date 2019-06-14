﻿using System;
using System.Collections.Generic;
using System.Text;
using TaileOfFriend.DAL.Enteties;

namespace TaileOfFriend.DAL.Interfaces
{
    public interface IProfileRepository:IRepository<Profile>
    {
        Profile GetById(string id);
    }
}
