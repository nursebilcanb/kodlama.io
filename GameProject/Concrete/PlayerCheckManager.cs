﻿using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class PlayerCheckManager : IPlayerCheckService
    {       
        public bool CheckIfRealPerson(Player player)
        {
            return true;
        }
    }
}
