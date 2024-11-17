﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HW3_RegistrationForm.Pages
{
	public class PrivacyModel : PageModel
	{
		private readonly ILogger<PrivacyModel> _logger;

		public PrivacyModel(ILogger<PrivacyModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{
		}
	}

}
