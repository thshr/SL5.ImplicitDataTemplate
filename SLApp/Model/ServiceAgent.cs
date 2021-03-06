﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SLApp.Model
{
    public class ServiceAgent
    {
        public void GetPerson(Action<Person> userCallback)
        {
            var person = new Person
                             {
                                 Name = "Briana Blonde",
                                 Birthday = new DateTime(2000, 1, 30),
                                 Bio =
                                     "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam vulputate fringilla risus vitae commodo. Aliquam at est in ipsum iaculis eleifend eu ut dui. Ut nec mattis ante. Sed nec eros eu quam convallis cursus. Nunc ultrices dictum sem aliquam faucibus. Donec rutrum ante sed augue auctor lobortis vehicula ligula posuere. Proin est orci, consequat quis accumsan feugiat, ultrices ut lacus. In faucibus, justo sit amet cursus tincidunt, nulla urna facilisis sapien, non viverra nulla nulla facilisis ligula.",
                                 Picture = "../Views/img/blonde.jpg"
                             };
            userCallback(person);
        }

        public void GetCar(Action<Car> userCallback)
        {
            var car = new Car
                          {
                              Model = "LX 2000",
                              Type = "Limousine",
                              Image = "../Views/img/car.jpg",
                              Year = 2011
                          };
            userCallback(car);
        }

        public void GetHouse(Action<House> userCallback)
        {
            var house = new House
                            {
                                Address = "Boulevard 12",
                                HasPool = true,
                                Map = "../Views/img/france.jpg",
                                Space = 1000
                            };
            userCallback(house);
        }

        public void GetContents(Action<List<IContent>> userCallback)
        {
            var contents = new List<IContent>
                               {
                                   new Person
                                       {
                                           Name = "Briana Blonde",
                                           Birthday = new DateTime(1980, 1, 30),
                                           Bio =
                                               "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris convallis, mauris eget imperdiet sodales, arcu quam laoreet quam, sed faucibus nisi est vel purus. Nam ultrices molestie neque, nec sagittis enim blandit blandit. Aenean cursus leo ullamcorper leo aliquam ultricies accumsan tellus rutrum. Donec congue augue vel dolor consequat placerat. Morbi quis eros ligula. Pellentesque ac enim vel tortor pulvinar gravida. Praesent iaculis nibh ut mi pharetra facilisis. Aliquam sed mattis ipsum. Suspendisse porttitor dignissim facilisis. Suspendisse mi nulla, tincidunt non auctor in, viverra feugiat purus. Etiam imperdiet, ipsum at tempor condimentum, leo eros mollis lacus, eu vehicula leo purus ut purus. Donec lobortis pharetra ullamcorper. Vestibulum interdum dui sit amet neque euismod porttitor. Nulla luctus neque eu nibh mollis porttitor. Integer quam libero, euismod vel sagittis nec, pharetra et ipsum.",
                                           Picture = "../Views/img/blonde.jpg"
                                       },
                                   new Car
                                       {
                                           Model = "LX 2000",
                                           Type = "Limousine",
                                           Image = "../Views/img/car.jpg",
                                           Year = 2011
                                       },
                                   new House
                                       {
                                           Address = "Boulevard 12",
                                           HasPool = true,
                                           Map = "../Views/img/france.jpg",
                                           Space = 1000
                                       },
                                   new Person
                                       {
                                           Name = "Lexus Blue",
                                           Birthday = new DateTime(1985, 3, 15),
                                           Bio =
                                               "Maecenas quis ante sed orci ornare sollicitudin ut in sapien. Nam blandit, nisl id pharetra pharetra, est tellus vestibulum massa, vel porttitor risus odio et dolor. Nullam fringilla, orci pretium pretium congue, magna magna fringilla lacus, et convallis odio leo ut metus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sed felis lacus, et facilisis arcu. Curabitur in velit libero, pulvinar auctor purus. Quisque congue pretium nulla, et eleifend turpis viverra sit amet. Donec arcu dolor, accumsan nec luctus vel, lacinia quis augue. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Praesent nec felis nisi, et tincidunt purus. Sed at orci tortor, at vulputate justo. In hac habitasse platea dictumst. Sed vel lacus tellus. Curabitur viverra felis sed elit laoreet rutrum. Maecenas eleifend, dui at rhoncus faucibus, ipsum mauris lacinia nisi, a ultrices libero arcu nec urna.",
                                           Picture = "../Views/img/blonde2.jpg"
                                       },
                                   new Person
                                       {
                                           Name = "Morning Star",
                                           Birthday = new DateTime(1979, 5, 21),
                                           Bio =
                                               "Vestibulum tincidunt neque faucibus justo blandit pellentesque. Nunc vel diam mollis velit blandit lobortis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nullam tincidunt, metus eget egestas elementum, nulla erat faucibus sem, vel varius dui lorem auctor turpis. Proin aliquet urna a leo consequat nec eleifend velit aliquet. Vivamus a dui ante, sit amet pellentesque mi. Sed malesuada tristique eleifend. Integer turpis lorem, cursus et pellentesque vitae, fringilla non dolor. Nullam tortor dui, consequat iaculis tempor congue, eleifend non lectus. Nulla facilisi.",
                                           Picture = "../Views/img/blonde3.jpg"
                                       },
                                   new Person
                                       {
                                           Name = "Steel Blue",
                                           Birthday = new DateTime(1983, 8, 11),
                                           Bio =
                                               "Mauris pellentesque pulvinar nisi in pellentesque. Praesent eleifend massa id orci auctor tristique. In eget mauris non metus bibendum interdum vel ut turpis. Praesent ante sapien, hendrerit nec molestie ut, elementum eu ligula. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse auctor diam ornare augue congue ut ultrices quam venenatis. Proin dictum lectus vel erat commodo condimentum. Vestibulum vulputate tempus faucibus. Curabitur massa erat, faucibus non vestibulum a, interdum ut enim. In non vestibulum metus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam erat volutpat. Nulla facilisi.",
                                           Picture = "../Views/img/blonde4.jpg"
                                       }
                               };
            userCallback(contents);
        }
    }
}
