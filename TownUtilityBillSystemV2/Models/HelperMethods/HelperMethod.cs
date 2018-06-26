﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;

namespace TownUtilityBillSystemV2.Models.HelperMethods
{
	public static class HelperMethod
	{
		private static Random rnd = new Random();

		public static string GetCurrentLanguage()
		{
			return Thread.CurrentThread.CurrentCulture.ToString();
		}

		public static string GetUtilityImage(int utilityId)
		{
			using (var context = new TownUtilityBillSystemV2Entities())
			{
				IMAGE_UTILITY imageDB = null;
				string imageName = "";
				string imagePathForHtml = "";
				string imagePathDB = "";
				string folderName = "";

				var utilityDB = context.UTILITYs.Where(b => b.ID == utilityId).FirstOrDefault();

				if (utilityDB != null)
					imageDB = context.IMAGE_UTILITYs.Where(i => i.ID == utilityDB.IMAGE_ID).FirstOrDefault();

				if (imageDB != null)
				{
					imagePathDB = imageDB.PATH.ToString();
					folderName = Path.GetFileName(Path.GetDirectoryName(imagePathDB));
					imageName = Path.GetFileName(imagePathDB);
					imagePathForHtml = "/Content/Images/" + folderName + "/" + imageName;
				}
				return imagePathForHtml;
			}
		}

		public static void Shuffle<T>(List<T> list)
		{
			int n = list.Count;

			while (n > 1)
			{
				n--;
				int k = rnd.Next(n + 1);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}
	}
}