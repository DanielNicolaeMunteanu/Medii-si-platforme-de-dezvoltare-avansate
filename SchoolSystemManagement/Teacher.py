class Teacher():
    def __init__(self):
        self.courseTeachers = dict()
    
    def AssignTeacherToCourse(self, teacher_name, teacher_course):
        if not teacher_name in self.courseTeachers.keys():
            self.courseTeachers[teacher_name] = {}
            self.courseTeachers[teacher_name]["course"] = teacher_course
        else:
            print(f"The {teacher_name} is already register ")
        print(self.courseTeachers)