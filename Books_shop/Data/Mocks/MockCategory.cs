using Books_shop.Data.Interfaces;
using Books_shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books_shop.Data.Mocks
{
    public class MockCategory : IBooksCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Художня література", description = "Романи, повісті, оповідання, вірші, драми та інші літературні твори."},
                    new Category {categoryName = "Наукова література", description = "Книги з наукових дисциплін, таких як фізика, хімія, біологія, математика, інженерія, медицина та інші."},
                    new Category {categoryName = "Історична література", description = "Книги про історію різних країн, цивілізацій, культур, подій та особистостей."},
                    new Category {categoryName = "Біографії та мемуари", description = "Книги про життєві історії видатних людей, або про досвід, переживання та спогади автора."},
                    new Category {categoryName = "Релігійна література", description = "Книги, які описують релігійні погляди, традиції, історію та релігійні тексти."},
                    new Category {categoryName = "Хобі та розваги", description = "Книги про спорт, ремесла, мистецтво, музику, кулінарію та інші."},
                    new Category {categoryName = "Ділова література", description = "Книги про бізнес, менеджмент, маркетинг, фінанси, лідерство та інші аспекти професійного розвитку."},
                    new Category {categoryName = "Підручники та навчальні матеріали", description = "Книги з різних навчальних дисциплін, включаючи мови, історію, науку, технології, техніку та інші."},
                    new Category {categoryName = "Дитяча література", description = "Книги для дітей, включаючи казки, історії, наукові книги, енциклопедії та інші."},
                    new Category {categoryName = "Саморозвиток та психологія", description = "Книги, присвячені саморозвитку, психології та психотерапії."},
                };

            }

        }
    }
}
