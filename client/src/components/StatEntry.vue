<template>
<div class="stat_entry">
    <form class="entry_form">
        Name: <input type="text" name="player_name" v-model="player_name" />
        Passing Attempts: <input type="number" name="pass_attempts" v-model="pass_attempts" />
        Completions: <input type="number" name="pass_completions" v-model="pass_completions" />
        Passing Yards: <input type="number" name="pass_yards" v-model="pass_yards" />
        Passing Touchdowns: <input type="number" name="pass_td" v-model="pass_td" />
        <button type="submit" v-on:click.prevent="submitStats" >Submit</button>
    </form>
</div>
    
</template>

<script>
export default {
  name: "StatEntry",
  data: function() {
    return {
      player_name: "",
      pass_attempts: 0,
      pass_completions: 0,
      pass_yards: 0,
      pass_td: 0
    };
  },
  methods: {
    submitStats: function() {
      fetch("https://localhost:5001/api/playerstats", {
        method: "POST",
        headers: {
          "Content-type": "application/json"
        },
        body: JSON.stringify({
          name: this.player_name,
          passingAttempts: this.pass_attempts,
          passingCompletions: this.pass_completions,
          passingYards: this.pass_yards,
          passingTouchdowns: this.pass_td
        })
      })
        .then(resp => resp.json())
        .then(stats => {
          console.log(stats);
        });
    }
  }
};
</script>

<style>
.stat_entry {
  display: flex;
  flex-direction: column;
  align-items: center;
  height: 100%;
  width: 100%;
  border: solid black 3px;
}
.entry_form {
  display: flex;
  flex-direction: column;
  align-items: center;
}

input {
  padding: 0.5em;
  margin: 2em 0;
  width: 20em;
}
button {
  padding: 1em;
  background: black;
  color: white;
  border-radius: 25%;
}
</style>
