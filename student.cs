 class Student
    {

        private string Name; // 1.truong

        // 2. Thuoc tinh
        public string StudentName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        //3. Phuong thuc (Method)
        public  Student()
        {
           
        }
        // 4. Phuong thuc(Method) Talk
        public void Talk(string stName)
        {
            
        }

        private void btnTalk_Click(object sender, RoutedEventArgs e)
        {
            Student st1 = new Student("minh");
            st1.Talk();
            Student st2 = new Student();
            st1.StudentName = "dung"
            st1.Talk();
        }
        
