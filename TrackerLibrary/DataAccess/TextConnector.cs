﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
	public class TextConnector : IDataConnection
	{
		// TODO - Make the CreatePrize save to a text file
		public PrizeModel CreatePrize(PrizeModel model)
		{
			// Load the text file
      // Convert the text to List<PrizeModel>
      // Find the max ID
      // Add the new record with the new ID (max + 1)
      // Convert the prizes to list<string>
      // Save the list<string> to the text file

      
		}
	}
}
