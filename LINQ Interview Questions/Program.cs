//left Join ==>
//from e employee
//join d dept
//on e.deptid equals d.id into deptGroup
//from d in deptGroup.DefaultIfEmpty()
//select	new
//        {
//            e.Name,
//            DeptName = d != null ? d.Name : "No dept"
//        };s


//RightJoin =>
//from e employee
//join d dept
//on e.deptid equals d.id into empGroup
//from e in empGroup.DefaultIfEmpty()
//select new
//{
//    Name = e != null ? e.Name = "No Emp",
//    DeptName = d.DeptName
//};


//normal Join ==>
//from e employee
//join d dept
//on e.deptid euqals d.deptid 
//select new
//       {
//           e.Name,
//           d.DeptName
//       };


//5th highest salary LINQ
//public class Employee
//{
//    public int EmpId { get; set; }
//    pubic decimal Salary { get; set; }
//}

//var 5thHighestSal = employees
//					.Select(e => e.Salary)
//					.Distinct()
//					.OrderByDescending(s => s)
//					.Skip(4)
//					.FirstOrDefault();



//With rankedSalary as(
//	select salary,
//DENSE_RANK() OVER (ORDER BY SALARY DESC) AS RANKNUM
//	FROM EMP
//)

//select salary from rankedSalary
//where RANKNUM =2;