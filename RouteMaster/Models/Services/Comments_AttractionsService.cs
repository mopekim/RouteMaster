﻿using RouteMaster.Models.Dto;
using RouteMaster.Models.Infra.Criterias;
using RouteMaster.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RouteMaster.Models.Services
{
	public class Comments_AttractionsService
	{
		private IComments_AttractionsRepository _repo;

		public Comments_AttractionsService(IComments_AttractionsRepository repo)
		{
			_repo = repo;
		}

		public IEnumerable<Comments_AttractionsIndexDto> Search(Comments_AttractionCriteria criteria)
		{
			return _repo.Search(criteria);
		}
	}
}