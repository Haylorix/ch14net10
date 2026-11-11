using Shape_AA;

Rectangle r = new Rectangle { Height = 3, Width = 4.5 };
WriteLine($"Rectangle r has Height = {r.Height}, Width = {r.Width}, Area = {r.Area}");
Square s = new(5);
WriteLine($"Square Height = {s.Height}, Width = {s.Width}, Area = {s.Area}");
Circle c = new(radios: 2.5);
WriteLine($"Circle Height = {c.Height}, Width = {c.Width}, Area = {c.Area}");

