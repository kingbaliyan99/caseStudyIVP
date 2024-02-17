import React, { useEffect, useState } from 'react'
import DataTable from './DataTable';

  
  const columns = [
    { field: 'id', headerName: 'User ID', width: 150 },
    { field: 'name', headerName: 'Name', width: 150 },
    { field: 'username', headerName: 'Username', width: 150 },
    { field: 'email', headerName: 'Email', width: 150 },
  ];

  const userTableStyle={
    height: '650px',
    width: '800px'
  }

const UserData = () => {

    const[users,setUsers] = useState([])

    useEffect(()=>{
        fetch('https://jsonplaceholder.typicode.com/users')
      .then((response) => response.json())
      .then(json => setUsers(json))
    },[])

  return (
   <DataTable
   rows={users}
   columns={columns}
   sx = {userTableStyle}
   />
  )
}

export default UserData
