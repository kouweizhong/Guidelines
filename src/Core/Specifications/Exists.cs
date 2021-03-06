﻿namespace Guidelines.Core.Specifications
{
    public class Exists<TEntity> : ISpecification<TEntity> 
        where TEntity : class
    {
        public bool IsSatisfiedBy(TEntity item)
        {
            return item != null;
        }
    }
}
