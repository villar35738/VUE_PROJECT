<template>
  <div id="app">
    <Alunos/>
  </div>
</template>

<script>
import Alunos from './components/Aluno/Alunos'

export default {
  name: 'App',
  components: {
    Alunos
  }
}
</script>

<style>
@import url("https://fonts.googleapis.com/css?family=Montserrat:400,700");

body{
  background-color: #eee;
  font-family: 'Montserrat', sans-serif;
  display: grid;
  justify-items: center;
}
body, html{
  margin: 0;
  height: 100%;
}
#app {

}
.btn{
  background-color:red;
  border: 1px solid black;
  padding: 10px 20px;
  color: white;
  cursor: pointer;
  font-weight: bold;
  border-radius: 5px;
  border-bottom: 3px solid black;
}
.btn:hover{
  text-shadow: 1px 1px 1px black;
  margin-top: 3px;
  border-bottom: 1px solid black;
}
table {
  margin: 0px;
  padding: 0px;
  list-style-type: none;
  width: 100%;
}
table tr td{
  padding: 20px;
  font-size: 1.3em;
  background-color: rgb(218, 229, 253);
  margin-bottom: 2px;
  color: blue;
}
table thead th{
  background-color: rgb(99, 201, 201);
  font-size: 1.2em;
  padding: 10px 0px;
  text-align: center !important;
}
.colPequeno{
  widows: 5%;
}
</style>
