using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstract
{
    // IEntity imlement eden classlar bir veritabanı tablosuna eşittir.
    public interface IEntity
    {
        public int Id { get; set; }
    }
}
