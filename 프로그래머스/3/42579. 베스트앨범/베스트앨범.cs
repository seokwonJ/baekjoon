using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    
    // 노래 정보를 담기 위한 구조체
    public struct Song {
        public int id;
        public int play;
    }

    public int[] solution(string[] genres, int[] plays) {
        // Key: 장르 이름, Value: 장르의 총 재생 횟수
        Dictionary<string, int> genreTotalPlays = new Dictionary<string, int>();
        
        // Key: 장르 이름, Value: 해당 장르에 속하는 노래 리스트
        Dictionary<string, List<Song>> genreSongs = new Dictionary<string, List<Song>>();

        // 1. 장르별 데이터 취합 및 총 재생 횟수 계산
        for (int i = 0; i < genres.Length; i++) {
            string genre = genres[i];
            int play = plays[i];
            
            // 총 재생 횟수 업데이트
            if (genreTotalPlays.ContainsKey(genre)) {
                genreTotalPlays[genre] += play;
            } else {
                genreTotalPlays.Add(genre, play);
                genreSongs.Add(genre, new List<Song>());
            }
            
            // 노래 리스트에 추가
            genreSongs[genre].Add(new Song { id = i, play = play });
        }

        // 2. 장르 순서 결정: 총 재생 횟수 내림차순 정렬
        // KeyValuePair를 재생 횟수(Value) 기준으로 내림차순 정렬
        var sortedGenres = genreTotalPlays
                            .OrderByDescending(kv => kv.Value)
                            .Select(kv => kv.Key) // 정렬된 장르 이름만 추출
                            .ToList();

        // 3. 노래 선택 및 최종 리스트 구성
        List<int> bestAlbum = new List<int>();

        foreach (string genre in sortedGenres) {
            List<Song> songs = genreSongs[genre];

            // 장르 내에서 노래를 수록 기준에 따라 정렬합니다.
            // 1) 재생 횟수 내림차순 (plays 내림차순)
            // 2) 재생 횟수가 같으면 고유 번호 오름차순 (id 오름차순)
            songs = songs
                    .OrderByDescending(s => s.play)
                    .ThenBy(s => s.id)
                    .ToList();
            
            // 최대 두 곡을 선택합니다.
            bestAlbum.Add(songs[0].id); // 첫 번째 노래는 무조건 선택

            if (songs.Count >= 2) {
                bestAlbum.Add(songs[1].id); // 두 번째 노래가 있다면 선택
            }
        }

        // 4. 결과 반환
        return bestAlbum.ToArray();
    }
}