<template>
    <div class="stat_display">
        <div class="player_stats">
            <h2>Michael Solone</h2>
            <div>Passing Attempts: 25</div>
            <div>Passing Completions: 25</div>
            <div>Completion Percentage: 100%</div>
            <div>Passing Yards: 400</div>
            <div>Yards/Completion: 16</div>
            <div>Passing TD: 4</div>
        </div>
    </div>
</template>

<script>
export default {
  name: "StatDisplay",
  data: function() {
    return {
      player_name: "",
      pass_attempts: 0,
      pass_completions: 0,
      pass_yards: 0,
      pass_td: 0
    };
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
}

.player_stats {
    display: flex;
    flex-direction: column;

}
</style>
