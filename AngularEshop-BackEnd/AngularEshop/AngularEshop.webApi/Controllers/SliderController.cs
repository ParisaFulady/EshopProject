using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularEshop.Core.Services.Interfaces;
using AngularEshop.Core.Utilities.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularEshop.webApi.Controllers
{
  
    public class SliderController : SiteBaseController
    {
        private ISliderService sliderService;
        public SliderController(ISliderService SliderService)
        {
            this.sliderService = SliderService;

        }
        [HttpGet("GetActiveSliders")]
        public async Task<IActionResult> GetActiveSliders()
        {
            var sliders = await sliderService.GetActiveSliders();

            return JsonResponseStatus.Success(sliders);
        }
    }
}
