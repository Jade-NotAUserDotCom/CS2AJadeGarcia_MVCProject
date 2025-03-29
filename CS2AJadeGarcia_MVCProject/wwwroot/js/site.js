const AddStudent = async (student) => {
    try {
        const result = await AjaxPost('Student/AddStudent');
        if (result.success) {
            alert('Student Added Successfully!');
            window.location.href = '/Student/Index';
        } else {
            alert('Failed to add Student: ' + result.message);
        }
    }
    catch (error) {
        console.error('Error adding student: ', error);
        alert('An error occurred while adding the Student.');

    }
};
 
$(document).ready(function () {
    $(.'3addStudentForm').on('submit', function (e) {
        e.preventDefault();
        const student = {
            firstname: $('#firstname').val(),
            lastname: $('#lastname').val(),
            age: $('#age').val(),
            course: $('#course').val(),
        };
        AddStudent(student);
    });
});
