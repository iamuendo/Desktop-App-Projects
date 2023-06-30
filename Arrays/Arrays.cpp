/* Grading System
I created a roster of students assigned to classrooms and their corresponding courses for math and science*/
#include <iostream>
#include <string>
using namespace std;

int main() {
    const int classrooms = 3;
    const int studentsPerClassroom = 4;
    const int courses = 2;

    // Use the 2D array to rep students for each class room
    string students[classrooms][studentsPerClassroom] = {
        {"Munene", "Njeri", "Kuria", "Wambui"}, // 1st Class
        {"Njuguna", "Otieno", "Samuel", "Wairimu"}, // 2nd Class
        {"Kairu", "Juma", "Kasim", "Akinyi"} // 3rd Class
    };

    // 3D array representing courses for each student in each classroom
    char studentcourses[classrooms][studentsPerClassroom][courses] = {
        {{'A', 'B'}, {'B', 'C'}, {'A', 'A'}, {'C', 'B'}},
        {{'B', 'C'}, {'A', 'A'}, {'B', 'B'}, {'C', 'C'}},
        {{'A', 'B'}, {'C', 'B'}, {'B', 'A'}, {'A', 'A'}}
    };

    // Accessing and displaying the classrooms, students, and courses

    // 2D 
    for (int i = 0; i < classrooms; ++i) {
        cout << "Classroom " << i + 1 << " students:\n";


        // 2D + 3D 
        for (int j = 0; j < studentsPerClassroom; ++j) {
            cout << "Student: " << students[i][j] << endl;
            cout << "Math Grade: " << studentcourses[i][j][0] << endl;
            cout << "Science Grade: " << studentcourses[i][j][1] << endl;
            cout << "\n";
        }
        cout << "\n";
    }

    return 0;
}
