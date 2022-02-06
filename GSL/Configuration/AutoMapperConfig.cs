﻿using GSL.Application.AutoMapper;

namespace GSL.Configuration
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(DomainToViewModel), typeof(ViewModelToDomain));
        }
    }
}
