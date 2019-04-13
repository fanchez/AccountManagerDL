using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaestroCuentas.Data.Core
{
    public abstract class ServicioDataBase<TEntity, TContext>
        where TEntity : class
        where TContext : DbContext
    {
        public ServicioDataBase(IMapper mapper, TContext context)
        {
            Context = context;
            Mapper = mapper;
        }
        protected TContext Context { get; set; }
        protected IMapper Mapper { get; set; }
        public IQueryable<TDto> GeTALL<TDto>()
        {
            DbSet<TEntity> table = Context.Set<TEntity>();
            return Mapper.ProjectTo<TDto>(table);

        }
    }
}
