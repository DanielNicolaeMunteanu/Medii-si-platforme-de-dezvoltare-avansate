class Student():
    def __init__(self):
        self.studentCourses = dict()
        self.studentGrades = dict()
        
    def RegisterStudentToCourse(self, student_name, student_course):
        if not student_name in self.studentCourses.keys():
            self.studentCourses[student_name] = {}
            self.studentCourses[student_name]["course"] = student_course
            self.studentCourses[student_name]["grade"] = None
        else:
            print(f"The {student_name} is already register ")
        print(self.studentCourses)
    def UnregisterStudentFromCourse(self, student_name, student_course):
        if student_name in self.studentCourses.keys():
            self.studentCourses[student_name]['course'] = None
            self.studentCourses[student_name]['grade'] = None
        else:
            print(f"{studentName} is not registered to any courses.")
        print(self.studentCourses)

    def GradeStudent(self, student_name, grade_value):
        if student_name in self.studentCourses.keys():
            self.studentCourses[student_name]['grade'] = grade_value
        else:
            print(f"{student_name} is not registered to any courses.")
        print(self.studentCourses)
        