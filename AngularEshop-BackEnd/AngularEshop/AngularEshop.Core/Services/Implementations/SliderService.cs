﻿using AngularEshop.Core.Services.Interfaces;
using AngularEshop.DataLayer.Entities.Site;
using AngularEshop.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularEshop.Core.Services.Implementations
{
    public class SliderService : ISliderService
    {
        private IGenericRepository<Slider> sliderRepository;

        public  SliderService(IGenericRepository<Slider> sliderRepository)
        {
            this.sliderRepository = sliderRepository;
        }
        #region slider
        public async Task<List<Slider>> GetAllSliders()
        {
            return await sliderRepository.GetEntitiesQuery().ToListAsync();
        }

        public async Task<List<Slider>> GetActiveSliders()
        {
            return await sliderRepository.GetEntitiesQuery().Where(s => !s.ISDelete).ToListAsync();
        }

        public async Task AddSlider(Slider slider)
        {
            await sliderRepository.AddEntity(slider);
            await sliderRepository.SaveChanges();
        }

        public async Task UpdateSlider(Slider slider)
        {
            sliderRepository.UpdateEntity(slider);
            await sliderRepository.SaveChanges();
        }

        public async Task<Slider> GetSliderById(long sliderId)
        {
            return await sliderRepository.GetEntityById(sliderId);
        }

#endregion

        #region dispose

        public void Dispose()
        {
            sliderRepository?.Dispose();
        }

        #endregion
    }
}
