// list to fix the array problem as it has fixed number of elements

List<int> student1grades = new List<int> { 100 , 99, 80};

// to add elements to the array

student1grades.Add(200);
student1grades.Add(300);
student1grades.Add(300);
student1grades.Add(300);
student1grades.Add(300);
student1grades.Add(300);


student1grades.TrimExcess(); // to remove any exess capacity more that the elemnts 

student1grades.Add(300);

Console.WriteLine(student1grades.Count);
Console.WriteLine(student1grades.Capacity); // how many elements in the list




