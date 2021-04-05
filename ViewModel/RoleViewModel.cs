using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Lab1.Model;

namespace Lab1.ViewModel
{
    class RoleViewModel
    {
        public ObservableCollection<Role> ListRole { get; set; } = new ObservableCollection<Role>();
        public RoleViewModel()

 {
 this.ListRole.Add(new Role
 {
 Id = 1,
 NameRole = "Директор"
 });
 this.ListRole.Add(new Role
 {
 Id = 2,
 NameRole = "Бухгалтер"
 });
this.ListRole.Add(new Role
{
    Id = 3,
    NameRole = "Менеджер"
});
 }
        public int MaxId()
        {
            int max = 0;
            foreach (var r in this.ListRole)
            {
                if (max < r.Id)
                {
                    max = r.Id;
                };
            }
            return max;
        }

    }
}
