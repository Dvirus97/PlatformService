﻿using PlatformService.Models;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;
        public PlatformRepo(AppDbContext context) => this._context = context;

        public void CreatePlatform(Platform platform)
        {
            if (platform == null) throw new ArgumentNullException(nameof(platform));
            _context.Platforms.Add(platform);
            // SaveChanges(); // manually Save in Code.
        }

        public IEnumerable<Platform> GetAllPlatform() => _context.Platforms.ToList();

        public Platform? GetPlatformById(int id) =>
                _context.Platforms.FirstOrDefault(p => p.Id == id);

        public bool SaveChanges() => _context.SaveChanges() >= 0;
    }
}
