﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
	class Program
	{
		static void Main(string[] args)
		{
			Zarosanas objekts = new Zarosanas();
			objekts.Funkcijas();

			/*
			Zarosanas jaunsobjekts = new Zarosanas();
			JaunaKlase1 objekts = new JaunaKlase1(); //"objekts" ir definēts kā jauns klases objekts

			// <5  >5
			Console.WriteLine("Izveelieties uzdevumu (1 vai 2):");
			Console.WriteLine("1 - skaitlu saskaitisana");
			Console.WriteLine("2 - skaitlu salidzinasana");
			string izvele = Console.ReadLine();

			
			if (izvele == "1") //lai salīdzinātu string vērtību, tā jāliek pēdiņās
			{
				objekts.Rezultats();
			}
			else
			{
				if (izvele == "2")
				{
					jaunsobjekts.LielaksVaiMazaks();
				}
				else
				{
					Console.WriteLine("Nepareiza veertiiba!");
				}
			}
			
				
			switch (izvele)
			{
				case "1":
					objekts.Rezultats();
					break; //break norāda, ka ja atbilst, tālāk nepārbauda
				case "2":
					jaunsobjekts.LielaksVaiMazaks();
					break;
				default: //visi pārējie gadījumi (kā else)
					Console.WriteLine("Nepareiza veertiiba!");
					break;
			}
			*/

			Console.ReadLine();
		}
	}
}
