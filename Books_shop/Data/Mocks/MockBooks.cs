using Books_shop.Data.Interfaces;
using Books_shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books_shop.Data.Mocks
{
    public class MockBooks : IAllBooks
    {
        private readonly IBooksCategory _categoryBooks = new MockCategory();

        public IEnumerable<Book> Books
        {
            get
            {
                return new List<Book> {
                     new Book {
                        name = "Есенціалізм",
                        author = "Грег МакКеон",
                        shortDesc = "Миcтeцтвo визнaчaти пpiopитeти",
                        longDesc="Чи відчували ви коли-небудь, що викладаєтеся на повну, але не отримуєте бажаного результату? Перепрацьовуєте й водночас не займаєтеся тим, чим потрібно?.. Ґреґ Маккеон пропонує власну концепцію Есенціалізму, завдяки якій ви навчитеся помічати найсуттєвіше, відкидати непотрібне й устигати найважливіше.",
                        img="/img/есенціалізм.jpg",
                        price=350,
                        isFavourite=false,
                        available=true,
                        Category = _categoryBooks.AllCategories.Last()
                     },

                     new Book {
                        name = "Гаррі Поттер і прокляте дитя",
                        author = "Джоан Роулінг, Джек Торн, Джон Тіффані",
                        shortDesc = "Остання книга серії книг про Гаррі Поттера",
                        longDesc="30 вересня 2016 року у Києві в Українському домі пройшла презентація книги «Гаррі Поттер і Прокляте дитя» українською мовою. Згідно домовленості, адаптація п’єси британської письменниці Джоан Роулінг для різних країн почалася тільки після того, як твір офіційно презентували в Англії. Наприкінці липня в Лондоні відбулася прем’єра п’єси за мотивами нової історії.",
                        img="/img/гаррі поттер і прокляте дитя.jpg",
                        price=320,
                        isFavourite=true,
                        available=true,
                        Category = _categoryBooks.AllCategories.First()
                     },

                      new Book {
                        name = "Жінка, яка має план. Життя, сповнене пригод, краси й успіху",
                        author = "Мей Маск",
                        shortDesc = "Історії й уроки «сміливого, але обережного життя» моделі світового рівня, матері Ілона Маска",
                        longDesc="Я давно захоплююся Мей Маск і як моделлю, і як жінкою. Упродовж своєї кар’єри вона надихала безліч людей, а тепер її неймовірна мудрість і відвертість промовляють до нас зі сторінок цієї книжки - Карлі Клосс, американська модель",
                        img="/img/жінка яка має план.jpg",
                        price=400,
                        isFavourite=true,
                        available=true,
                        Category = _categoryBooks.AllCategories.ElementAt(4)
                     },

                        new Book {
                        name = "Місто дівчат",
                        author = "Елізабет Ґілберт",
                        shortDesc = "«Місто дівчат» — новий бестселер Елізабет Ґілберт, яка підкорила світ романами «Їсти, молитися, кохати» та «Природа всіх речей».",
                        longDesc="Роман «Місто дівчат» починається 1940 року, коли дев’ятнадцятилітню Вівіан Морріс виганяють з престижного коледжу. Батьки відправляють доньку на Мангеттен до тітки — власниці невеликого, проте дуже ексцентричного театру. Несподівано для себе Вівіан опиняється у справжньому вирі довоєнного богемного життя. Знайомства із зірками, незвичайні театральні постановки, нестримний секс, ріки алкоголю і відчуття цілковитої свободи спершу заворожують та спокушають, а потім вибивають землю з-під ніг. І це лише початок шляху Вівіан довжиною в життя, який необхідно пройти, щоб зрозуміти: ти не мусиш бути хорошою дівчинкою, щоб бути хорошою людиною.",
                        img="/img/місто дівчат.jpg",
                        price=350,
                        isFavourite=false,
                        available=true,
                        Category = _categoryBooks.AllCategories.ElementAt(1)
                     }
                };
            }
        }

        public IEnumerable<Book> getFavBooks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Book getObjectBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}

