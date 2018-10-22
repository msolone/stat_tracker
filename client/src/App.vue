<template>
  <div id="app">
    <h1 class="title">Stat Tracker!</h1>
    <div class="main">
    <StatEntry />
    <StatDisplay />
    </div>
  </div>
</template>

<script>
import StatEntry from "./components/StatEntry"
import StatDisplay from "./components/StatDisplay"

export default {
  name: 'app',
  components: {
    StatEntry,
    StatDisplay

  }
}
</script>

<style>
html {
  height: 100%;
}

body { 
 height: 100%
}

#app {
  height: 100%;
  display: flex;
  flex-direction: column;
  background: #F1F3F4;
}

.title {
  display: flex;
  justify-content: center;
}


.main {
  display: flex;
  height: 100%;
  justify-content: space-around;
  align-items: center
}

</style>
