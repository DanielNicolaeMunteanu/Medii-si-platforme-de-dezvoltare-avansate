from Student import Student
from Teacher import Teacher

class Interface:
    def __init__(self):
        self.student = Student()
        self.teacher = Teacher()

    def show_menu(self):
        print("| School Management System          |")
        print("| 1) Register student to course     |")
        print("| 2) Unregister student from course |")
        print("| 3) Assign teacher to course       |")
        print("| 4) Grade student                  |")
        print("| q) Quit                           |")

    def print_menu(self):
        while True:
            self.show_menu()
            choice = input("")
            if choice == '1':
                print("Enter student name:")
                student_name = input("")
                print("Enter student course:")
                student_course = input("")
                self.student.RegisterStudentToCourse(student_name, student_course)

            elif choice == '2':
                print("Enter student name:")
                student_name = input("")
                print("Enter student course:")
                student_course = input("")
                self.student.UnregisterStudentFromCourse(student_name, student_course)
                
            elif choice == '3':
                print("Enter teacher name:")
                teacher_name = input("")
                print("Enter teacher course:")
                teacher_course = input("")
                self.teacher.AssignTeacherToCourse(teacher_name, teacher_course)
                
            elif choice == '4':
                print("Enter student name:")
                student_name = input("")
                print("Enter the grade:")
                grade_value = input("")
                self.student.GradeStudent(student_name, grade_value)
                
            elif choice.lower() == 'q':
                print("GoodBye!")
                break
            else:
                print("The choice is invalid, please choose again")

if __name__ == '__main__':
    Interface().print_menu()

    