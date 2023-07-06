﻿using RouteMaster.Models.Dto;
using RouteMaster.Models.Infra.Criterias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RouteMaster.Models.Interfaces
{
	public interface IComments_AccommodationsRepository
	{
		IEnumerable<Comments_AccommodationsIndexDto> Search	(Comments_AccommodationCriteria criteria);

		void Create(Comments_AccommodationsCreateDto dto, HttpPostedFileBase[] file1, string path);

		void Update(Comments_AccommodationsEditDto dto);

		bool ExistImgWithinComment(int id);

		void ClearImg(int id);

		void DeleteComment(int id);
	}
}
