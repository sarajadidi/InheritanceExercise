﻿using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
            IsAlive = true;
			LegCount = 0;
            LandSeaAir = "Land";
            Age = 0;

        }

		public bool IsColdBlooded { get; set; }
		public bool IsScaly { get; set; }
		public string Habitat { get; set; }
		public bool CanRegrowTail { get; set; }



	}
}

