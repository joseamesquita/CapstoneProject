import React, { useState, useEffect } from 'react';
import Student from './UniversityRegistrar';

function StudentList() {
  const [studentList, setStudentList] = useState([]);
  const [error, setError] = useState(null);

  useEffect(() => {
    get();
  }, [])

  async function addStudent(student) {
    await fetch(`http://localhost:5000/api/Students`, {
      method: 'Post',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(student)
    })
  }

  async function get() {
    await fetch(`http://localhost:5000/api/Students`)
      .then(response => response.json())
      .then((jsonifiedResponse) => {
        setStudentList(jsonifiedResponse);
      })
      .catch((error) => {
        setError(error);
      });
  }

  async function deleteStudent(id) {
    await fetch(`http://localhost:5000/api/Students/${id}`, {
      method: 'DELETE'
    })
      .then(response => response.json())
      .then((jsonifiedResponse) => {
        setStudentList(jsonifiedResponse);
      })
      .catch((error) => {
        setError(error);
      });
  }
}