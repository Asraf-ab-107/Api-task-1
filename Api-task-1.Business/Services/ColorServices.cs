using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_task_1.Business.Services
{
    public class ColorService
    {
        private readonly Repository _repository;

        public ColorService(Repository repository)
        {
            _repository = repository;
        }

        public async Task<List<Color>> GetAllColorsAsync()
        {
            return await _repository.GetAllColorsAsync();
        }

        public async Task<Color> CreateColorAsync(string name)
        {
            var color = new Color { Name = name };
            return await _repository.CreateColorAsync(color);
        }
    }
}
