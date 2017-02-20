angular.module('fpl.controllers', [])
    .controller('searchController',['$scope', 'searchService', 
        function($scope, searchService) {
            this.players = [
                { 'id': 0, 'name': 'Alex' },
                { 'id': 1, 'name': 'John' },
                { 'id': 2, 'name': 'Mat' }
            ];
        searchService.getPlayer({
            playerData: {
                name:"Alex"
            },
            success: function() {
            
            },
            always:function() {
    
            }
            });  
        }
        ])