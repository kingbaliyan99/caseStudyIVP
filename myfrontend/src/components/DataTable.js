import React, { useState} from 'react'
import { DataGrid} from '@mui/x-data-grid';


const DataTable = ({
    rows,columns,sx
}) => {

const [pageSize,setPageSize] = useState(2)

  return (
    
    <DataGrid rows={rows}
     columns={columns} 
     sx={sx}
     checkboxSelection
     pagination
     pageSize={pageSize}
     onPageSizeChange = {(newPageSize)=> setPageSize()}
     rowPerPageOptios ={[2,5,10]}
      />

  )
}

export default DataTable
