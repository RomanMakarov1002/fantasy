angular.module('fpl.services', [])
    .service('searchService',
    [
        '$http', function($http) {
            this.getPlayer = function(options) {
                $http.get('/getPlayer', options.playerData)
                    .success(function(data) {
                        options.success && options.success();
                    })
                    .finally(
                        options.always && options.always());
            }
        }
    ]);