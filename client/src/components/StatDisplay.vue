<template>
    <div class="stat_display">
        <div class="player_stats" v-for="player in playerData" v-bind:key="player.id">
            <h2>{{player.name}}</h2>
            <div>Passing Attempts: {{player.passingAttempts}}</div>
            <div>Passing Completions: {{player.passingCompletions}}</div>
            <div>Completion Percentage: {{Math.floor((player.passingAttempts / player.passingCompletions) * 100)}}%</div>
            <div>Passing Yards: {{player.passingYards}}</div>
            <div>Yards/Completion: {{(player.passingYards / player.passingCompletions).toFixed(2)}}</div>
            <div>Passing TD: {{player.passingTouchdowns}}</div> 
        </div>
    </div>
</template>

<script>
export default {
  name: "StatDisplay",
  data: function() {
    return {
      playerData: [],
      player_name: "",
      pass_attempts: 0,
      pass_completions: 0,
      pass_yards: 0,
      pass_td: 0
    };
  },
  mounted: function() {
    fetch("https://localhost:5001/api/playerstats")
    .then(resp => resp.json())
    .then(playerStats => {
      console.log(playerStats)
      this.playerData = playerStats
    })
  }
};
</script>

<style>
.stat_display {
  display: flex;
  flex-direction: column;
  align-items: center;
  height: 100%;
  width: 100%;
  border: solid black 3px;
  overflow: scroll;
}

.player_stats {
    display: flex;
    flex-direction: column;

}
</style>
