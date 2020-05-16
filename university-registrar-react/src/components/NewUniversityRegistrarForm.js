import React from 'react';
import PropTypes from "prop-types"
import ReusableForm from "./ReusableForm";

function NewStudentForm(props) {
  function addNewStudent(event) {
    event.preventDefault();
    const student = {
      studentName: event.target.studentName.value,
      dateEnrolled: event.target.dateEnrolled.value,
      major: event.target.major.value,
      currentTerm: event.target.currentTerm.value,
      currentYear: event.target.currentYear.value,
    }
    props.onStudent(student);
  }

  return (
    <React.Fragment>
      <ReusableForm
        formSubmissionHandler={addNewStudent}
        buttonText="Save" />
    </React.Fragment>
  );
}

NewStudentForm.propTypes = {
  onAddStudent: PropTypes.func
};

export default NewStudentForm;