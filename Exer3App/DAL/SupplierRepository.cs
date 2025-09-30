﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DAL
{
    public class SupplierRepository
    {
        private readonly Exer3DbContext _context = new Exer3DbContext();

        public void AddSupplier(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }

        public Supplier GetSupplierById(int id)
        {
            return _context.Suppliers.FirstOrDefault(s => s.Id == id);
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _context.Suppliers.ToList();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            var existing = _context.Suppliers.FirstOrDefault(s => s.Id == supplier.Id);
            if (existing != null)
            {
                existing.Name = supplier.Name;
                existing.ContactEmail = supplier.ContactEmail;
                _context.SaveChanges();
            }
        }

        public void DeleteSupplier(int id)
        {
            var supplier = _context.Suppliers.FirstOrDefault(s => s.Id == id);
            if (supplier != null)
            {
                _context.Suppliers.Remove(supplier);
                _context.SaveChanges();
            }
        }
    }
}
