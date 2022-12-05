namespace AdventOfCodeDay3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string smallLetters = "abcdefghijklmnopqrstuvwxyz";
            string capitolLetters = smallLetters.ToUpper();

            List<string> input = Input().Trim().Split("\r\n").ToList();

            int sum = 0;
            for (int i = 0; i < input.Count; i++)
            {
                bool matchFound = false;
                if(i % 3 == 2)
                {
                    string first = input[i - 2];
                    string second = input[i - 1];
                    string last = input[i];

                    for (int j = 0; j < first.Length; j++)
                    {
                        char firstChar = first[j];
                        for (int k = 0; k < second.Length; k++)
                        {
                            char secondChar = second[k];
                            if (firstChar == secondChar)
                            {
                                for (int l = 0; l < last.Length; l++)
                                {
                                    char lastChar = last[l];
                                    if (firstChar == lastChar)
                                    {
                                        matchFound= true;
                                        if (Char.IsUpper(firstChar))
                                        {
                                            sum += (capitolLetters.IndexOf(firstChar) + 27);
                                        }
                                        else
                                        {
                                            sum += smallLetters.IndexOf(firstChar) + 1;
                                        }
                                        
                                    }
                                    if (matchFound)
                                    {
                                        break;
                                    }
                                }
                            }
                            if(matchFound)
                            {
                                break;
                            }
                        }
                        if (matchFound)
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }

        public static string Input()
        {
            return "mjpsHcssDzLTzMsz\r\ntFhbtClRVtbhRCGBFntNTrLhqrwqWMDMTWTqMq\r\nLltbngLGRSBgSgGRCJdSdQHvdfmQccmjSQ\r\nlBslsZDDWdGdGpSMts\r\ngrQhDvqLQHDNGJJtbRMQQJ\r\nHChCTnnLCgCrTZPPFzzVPcVD\r\nShrzjhNGrNqrhWnHHfVHbhnHbbhH\r\nRBsvcBcDCdsRTsvgCgcPFRQpVQGQJPVFbnJfbJ\r\nDvsTsdlCBsGLrjzmlqqz\r\nWJJqZTgCnBLGCZBJCJnTLggTDDSDDMNdDSdbdSSsWDFfMsFf\r\nPVjqpVHmPpvmcjhrRprFmQQffbfNbQMMsSMQNQ\r\ncwcpRvrVlVgwtBwZqBzZ\r\nqfJJmpqpmhsggvvpVPZCrhdFLFzZFDdLLh\r\nCtCTBctGcGLSzZddGZSW\r\nRlNjBCnjttBHHMMcQHCsRfsbfwgggmmJvmgfpm\r\nZmcgBBZhZMsnqnCPjpHPjLHp\r\ndGbNwNtlTMTzGfNvTvdwNGVLPpQHPjLQPCpCjPqjLbpLPR\r\ndvDTdfvNBhDZMBDZ\r\ncvvRvbqcllbBVlvVVbVVlbVDjRjDjdMsHPZPGdDPGPHrDP\r\nFwtpfwJtWwNtTTNnwFCtjDJsQdQPPPPMrjrPJHjH\r\nCwFpnppgntShgbsscbms\r\ncWMFMQpFNcvNDdBDgdsT\r\nMPrrfrCHBBsDZCBJ\r\nLmLjMLjjLWpVcRVR\r\nZrRZqlZMqTWrMDqwvnvVtnsvddvVnlVf\r\npQNhhLNNGmLjhhcfvndDpffdfdVf\r\nQGjCLCQGmNgPBQDFFgTMJWWwMRTrTZWWBWTr\r\nWrZWZPHHWZHprZVmVvqddBttBBhGhtvh\r\ngzDlMTJDMfqhBGllhl\r\njJLqMMDDbbqjLpPHcsHLWZspPr\r\nbsSVRVGsrDstrrSjcQjcjlPwzjQl\r\ngHBggFNTTvTgfqgCFzljWwLWQQQnrwQWnf\r\nNvJHgpgHvqBhNBJhHTvpBCJCZmtdpDsGsZdZMZRbVbbMdrZs\r\nMPPtPwPnRnMPPnwrtNSGgLSCGGGNSLtSgD\r\nhBhWFjfCsTbbbWqFFWBBqBhsWZVGSVglZHLSVDlNWDNHHGgV\r\nzsCfTsTCMdmRPwzQ\r\nJVQVvvszzvTsVsVJjctppcCtjtPRcTlP\r\nMdFgqSddMqMDbtDlNjRDSR\r\nqFZWZqwHlZfZvzvZfLZn\r\nvpqwQSsHSHDQzDpgzwZlRLRZRRZTnTrrvGhh\r\nJBcdmbmFMPgPbgfrZRZnRFFnrnLRln\r\nJNdBNgbdJmPMWSSDzwVDtwSWWW\r\nBDMcDDppHCStpWcHBDNtzPJjqGlllPMJzPGjwjlq\r\nCZdZLmgCdqbPzjblZj\r\nvndLfnghRQmVrhdvgBHpSCDWHBBCVHNppD\r\nWrhrJJGSWzpTWwts\r\nVlLPmqgmRNZRGwsvttjgcwsT\r\nPDZmlbdVqLmPlddVNRDmmmbbSFHrCFQCnFBFJHSJGrDQCBrr\r\nhvPdpvhHvHvPrNfVhDfjggFfRV\r\nzlGwJGslsSDRfjsg\r\nMJMWjMJzwqWGzJwMqJBTCmHndPPdCBvmdCpmHn\r\nPVWFpQhJhFJpGbRCvRHGCp\r\njgslDjftsqhNglTgllgTqMnlHwCcvwZwRccSRCbGSGbCMHRw\r\nTgjhNNnjlTfjTdDqTfhjnmzmWPzWrLdrQBPJFWJWBB\r\nqPPRMPlfSzSSSPPnnLnqMlpQQtrrtmWpbFtQrdzrtrWt\r\nBBvCcwsVThsBgswDBCFQHQpdmQvtrFpWFvWp\r\ngCghTJgVCgDGVMlRGMqZnSWqlM\r\nRWbHvrbHBsbWBHJWvJwMtmdZwdtmdvwMZQff\r\nDRVjcqhRchhGGllhCgdGQQzfttzGQGwQfg\r\ncDRljchpqTcjDFTFVcPcPCWBHpNnJNNSnbWbHHrSpWHr\r\ndtHrRrBHrCRhddftjgBrRhgjsbbbMpbSWSTjWcsDTWDbcW\r\nGQPFVQVQnJlqVMDcMzpDfzpDVD\r\nqZZJFLlLnvFFGPGLPqnJvwQldfgHrBRBmBhgNBRHghNhhwRg\r\nrLbrZhPgqZhMdVFSFTSGCqFG\r\nzsszfRzjtHtzvRTSDdFFCtdDdtND\r\nfcwllfmwzRHlfmmzFvQQLrgLMLBZhJQZPrZhJLhW\r\nsllrCfpQQJpMHLgzwDwpNqzzVDpV\r\nRZPFZPGcSMFtGPRGMwNDVwdRgzvNwgqNvg\r\nhBmbMcBmcThmcGtSFTZfQCJjrHLJfsjhWJssJl\r\nDqGCbGfCRhfZCVbbqDJJGJBgRNpNdpBNNgNBBNwHnRgt\r\nrcWSsSSPSQtwBwHD\r\nMLscLMzvvTvcTLzvWWFDPTTrGqmFGGqCZJGbblbVbVZZVmFJ\r\nFprpsLQTrstQHNmVSVml\r\nJMggWPggWcRbwgJPCGMcGcfmzHlMNSjfzVNhHfVtzSMz\r\ncwnPnBwgnGRgRCgRbWJLpFsLtFBLFrDLFZZDrL\r\nlVgjLLLMgFMDCwCFqCRbngsvnGSvnSGndbsfgf\r\nWZJcTWcNTmJZphmTJJNQHcdvfdbvnRRGbGthdrbttfSv\r\nZPQTJTpTNPJNQTmJRBZJNBHjwMVwPCMwVlVzjwwzqqjVjL\r\nhznNhNQNQFDWVFmDQm\r\nSMqZBMMbBvDbHPzzdVPH\r\nzzzTBTMLNTgpnTTh\r\nNLCdmsdCVLGHCHdQzzmznnFwRjFMDMwpTBjDRpnpTBMJ\r\nPrcfcrglcfWbSqgrlqvShrwpJpDBFJHpBWjTDTRTRTTB\r\ncrSgSHtPttfdLGmtzzZNNV\r\nBTlTVqCBqtTcBqVhWlsJjDvsnLsvlvpJPj\r\ngMgggGZbSMzNRRRLmZZnQZQPPDvnsnDvJwwQ\r\ndMRRmMgbNfRgmfSdGFgNgTBtrhrhqfWtLCCWLTWWHc\r\nzcfVrPwnwrPmrvnjdFdBbHFFdd\r\nCCqpSSQQpQZLDCSHPpBFvFBjTHRvRR\r\nDMLGthLZMLtQGhGNMPqGSDflzfwcVmzJzsfgNVrswcrr\r\nhSgvMTQvChSqPvhTrRLlVHJgfgRJlHHHJH\r\njmzsZzZzwmmLGGtwtVJWNNDRDtVcfVRl\r\nGnBBLbzzzFszBFpzvSdrQQCTCQbhMvSQ\r\nVHpTMrZMMbDbbpTZmQmTnmzhTqjqlWWQ\r\nGGvgNsvNCNvvGvlqqdzWZmlsmZqZ\r\nwNNNgccNGJSNBSRNBNvNcvJHLDDZMFRMppMLrfHDLbrrHF\r\nspssbPMLpPllspGNsNWMrnwddnfcqrnwwwwMwM\r\nVmQBFCjzzjmfnwbrngcVrd\r\nFQbSFjBvvzsWvWGlvWNl\r\nJLFSwfwRLLfGhnQJBQshvn\r\npZgNcpCWpWtcvhjGGjtVvszD\r\nCccMcPcgTTCWmcZcWMcmTNZPmHdrqSHFRRrqwrSrRqwrHmsH\r\nBPMhflJRhqnPNGjNRNRjgSRm\r\nVdVsDswTVZbCwCZBrcDCczTwtjtNNjmjmgpmjpQggpGVSgQm\r\nsTbWrsTBbrTPPnqlJnPPhW\r\nnvrgjMWBvQWPvQnsZfGcZcRFdGFtdtZB\r\nbHVDwmqNNDhHNzqpphLNHVLpSJcdZtfffRZdDgRFGSddcRZt\r\nHNLNqNqLNbhqVVbClngjnQWPTWgsCgvT\r\ntfstpcScscBTFTpFnsWSmgdzJlgmgBmPPzJmvdPm\r\njnrqrLHRwGrwhdPvvPvhjJmP\r\nqqCLRCGrZZqCHRVtVWQptFWppnbcWb\r\nwCDJZJgDwHpdqHhdGHBhhH\r\nWSPmJMlmbSmztQlQsvPhnhGGdBddBqdGddTbVB\r\nWzWQftWMSWtmvmmSWtMQPgggpZwLwZjggJFgrpFCfj\r\nMvQBJMBQhjQFNFnjnj\r\ndtlZmRtLmjSTSLLtTtNVwWzDRzDVwwWFwnNn\r\ndmmLCqTdcLqtLGqjBhpfHqBGpv\r\nPBPRhjTPPlLRBvlvfwffqJGfpG\r\nrHtMtrszFtSgbFrrggrFgMnwWGzmQqWvGWzGQpJGfNqqNz\r\nFggcbSMntVgMdRCwZcjChLCT\r\nlCqqBlCwlnDqPZTZZBLNdjJLwttNWjjdzJzc\r\nfVfMbvbvmbVsmSsmMVWNtzzcjgLWgjztMMtg\r\nVVmFhFRSfbQsvVQmvSfhSsmzHlCZqrrBrDBrHZPRTZnnzB\r\nCRrDWmzRRQMmDqrrBgBQmtHljhHwtwlwplcBjHGwwB\r\nPWfPSWnvsNZSZdfjHjZtGHjchllltl\r\nWVsnbSPTbNdbmqTQmmrmLzTq\r\ncGtMBGSJDgtgMBsBMgMvWWSHWjpjzHTWTPpqWzqW\r\nmNVQNsdVsdhLmCpTWWjmCjTT\r\nNQQwrfbQrNQNbrrdLwfQsZdgFbBBFBgggRGRDMRFFMRDgM\r\nlFnqgqWQvHWqgvlVglvqjPjcLdfLfBPLnrbLNLcN\r\nhmTmthppsRtpTRRTZMpSbLdNjNcJLcrcBNbJBZZc\r\nsmmpRsTtpSSsRGhppmmhdCMGWwqFQgWGWWDgWwVFHQqHgg\r\nmWFjmcdcFWcSSQjzrpvrwRGvTwQGGG\r\nHRJfgMZVhtRlHJHBVJTGvGppbpbvvGTvTtrv\r\nglsgVMVqffdnPRDcqLnL\r\nMtvLJdmLLTvSSCtSzLSTcDhRjRftQjjssshfQNjPtf\r\nnlggrFWzRsfFjVQN\r\nWgwwBgbgZBHGBnccTzMCLTZJmLLL\r\nsRtHTBBHZtDTtZhdPzWdGcdVFdJmGcnm\r\nwpwMLWCgvfNvwvwbbCrwgfzPncrJPSFVGPnrcJSVznmV\r\nbLpvwQwMwpjWMgfvgZTsDsBttqHRjTqHlH\r\nmpmGpCpmlpmwfmCQVppCVfQSSjvSqgWvvvDgNwWDgnnDnW\r\nRBLsHRJBRrHJWFDWSNqFWj\r\nzZBLdsdcZrsBjGfpGVpTTPGlVc\r\nNBbTzgwSNmrFWpVrzrFM\r\nLnZQtQlZVnMrFBBG\r\nCCdtddBtPdNqcvHSCCcg\r\nZFbZPHbZPTQVVlsGNF\r\nqtvDWvgRftqGNccCNVThDs\r\nfRwGBBjBppdMdBMZ\r\nGffflsZsPZVfjsssNfZsJNNZVcMDSqMWFcwFMMpcTMTTFSTS\r\nLhrCmvzcRbbhtmRdTCMDwWMpDWqqqMpW\r\ndvRQmBBvLzBRRvRhhcdbhdRgjHQNllJsfsNlZZljZGGNQN\r\nwjbMPsbfLzVCTMVbjLplmpshhSpHShhJhtsm\r\nZrcqZTDTGDqFdJtGmdGSpl\r\nQNNrWvQRqRNWnTQRvqjPbjfWbCBCMbMLBwMV\r\nwRPRsppFfWJRlPRPFlpJfwSMzzZTBwBtZTTCMCMtdz\r\nvGLGrjcfrLVGjfnGTMCMtNNnCTnMtCBd\r\nVrjqhjhLVcrGVRqJmqQspmfFWm\r\nLRfdnmwMwdSBmfvJNrrgLhCNgqqJWs\r\nllctPPVTcPStgJgshCsrCs\r\nDpTlFpFVRFZRFFSv\r\nsPgRgsmdcqmgSvvFRRRRdqdFfTWZhhdZrZbbWfTpwDfbWTbw\r\njLCCHtLljJzjlplfZSlwTfprZZ\r\ntBHVjQHzHQJBtSVmvRsvvFRqnGgv\r\nspppVDbVcbgVSFgFZZbGZgbJMRBTvHTvJJHGtHRwtMGvHT\r\nLldflzQLLQmQWQQfnwMWwHJtTtwRBcBt\r\nCPjfhCmNmNfFVchpchFVhp\r\nbZQJgQmQmTgnLBRtNPNnml\r\nccszcqldGzhszrVsqdlHVNwLpppwHPHRtBBppDNRLt\r\nVSzVhVdcfrrhcqGrVhrssQQlMbJvFjMgbFSQggCvCv\r\nhHWVWhhlZDZVWNTgczWLjbtcTFFj\r\nJJnPnCdBCBnnRCjSsjStBgsbFttb\r\nMRpgCpGqdPRppJwpnRqRfZZhmvhHDrhllDHhhZGZ\r\nSPcgLDcLLnWFWCNVCRPT\r\nfhZQtsbtmbmfZTVTVRWfNvTCTT\r\njhbbmzRsQzpLDcgLHLjg\r\nGSFRHrCCGRJDJtrgWdrL\r\nstcVQshQZBsBmjMsZhmMQQWDDvNWdncNWvzLgdDnzdDN\r\nsVwMBQBhVVjtQZVPlSfPCfwRpSCpRl\r\nbBHHJMJvBvWMJWqqccNNPhMCrclChQCC\r\nRPppPgfpwgmcQgrhmm\r\ntfwTwpFPGGwZSRtpVjJHbHLvSvLSqVLL\r\njlJfZGjljJPBqJGnfGVMqGfrFWWddvDmFRDcmdFDdDvbDM\r\nhTCTsgsgwhTbvRdcFmsddpFd\r\nwbQNHTQLgCwSThhCgwnZnJfqnqJBlNlBnnVl\r\nCLlfbjjbLlbbDGbLzfCGhdtdWBthdBWsHvWHBnntWs\r\nrmJRJFqrDwVFTwFmSJvtvMtdJMMHBdBBndWt\r\nZVrVVZpgTpZFSqmZqRNlNNfQQbpGjDQbbpPl\r\nmVCrhGHGmZhrNlDwbWnLWWvGLWWwnd\r\nPNsqgzspsgNFJNFfzqpWSWdwSvSPnvdWbSbvjd\r\nNzgJzqMcgscQqJcpJRzBmlrBRBDDlHZBBBHtHZ\r\nNJmNJDwcMmJNMbJJDNDqcGcsWRWHQzRPQjZLRGZWLQsjZQ\r\ndgSnTBgdpddtgShSTZjLRhRLHqWPPhPRPQ\r\nVgdTpBntlvBVrlfcbqJcMrfmcqmb\r\nwvqwvPwNJgFmLdvDJFDmDLvJlQZpMzSpBVflpdSSMlQnfldS\r\nWjCcRZCWRjjRtsZhRRhpSVBVnzplBfWnfBfSQz\r\nCbRbcsjHZrhbTRtsGbCrgNgDDPFFqvvJvJFDFw\r\nGlsCrbCChShqgqlbSCcVbqgVhBwjBDFBhBhdDWvwBFFvWvDv\r\nTHmHMmtMnLfHRnzRZnfLBDWWsWzWFNsvWjjvjvFF\r\nmpHRtmZffHTTMpmLMLLnJtJCgScScsPlblcpCrPbblCPlq\r\nvscDLrcvrsLNStdTfBCvgJTqGBdd\r\nbwLbzRhbbdTfbgCB\r\npplQzLwmPZVMStcDjFtQrS\r\nRMjCrhFJhRVRVCCFFsvmnvqrmbvqmqSmbrvm\r\ntzfpBgTHzttGzZpBfHGDBZHbccnGqbmvdNlGnSnlcvSwbn\r\npDWTHDTzgTfWZpVVsWSPjRFSMsFs\r\nfmrfmrwVfjmrzjqCsqqvjsvvpG\r\nhFDVtFStVtJnPPtJNHbtQWGbQsCvCsQgpWGggdQC\r\nNBSDSNHStHNHnhStHNNrcflrmTzBlwmzrlMVVw\r\nSjtZZSdNcDldPQqndl\r\nBbgzgWgTmTBfwrbnDjQDwVPwDlnsVq\r\nzBBrCTTMBWLMWmfMfbbmrMtjNZLFJRRZSSvFFtStvGGJ\r\nCTCGLGCFRRSMGnZnLCTfdffhpbNbDfpdZBvhdv\r\nrJlqclVPHJWVrgPPQqjqgJlhBhDBBQdvbhwvNfhswfNpvb\r\ntltrcrHjlVWVCDzSGCCzLCGt\r\nsbHHsbCCHbLSVfJbbfSLNJBzvzMMPrhPPNztZlZNZhdt\r\nGTWjplTgDnGmQGpQnQhZrvvBMPztPzvrzvjZ\r\nmQgGWllcFcTFmgwcDppDQGTCqfsSLqsfSbqJqLSSFsbRfF\r\njslsFjLLLLvFwWtQFTFDJQWp\r\ndGzdrNmRWqVBGcTbwpRDRnbJDRhT\r\nqzqzrrPNNrmfLPsjglHjgW\r\nQjCHcPfcgQSgPPcffQSmmmLmrJJpNpBMrJMtFrBBBMFrrpNS\r\nVGVZfDbbVVZWGvDbFrlBZNJBNlNMwwtM\r\nsbvfhqTGTRnhTVGvzgHmgQLQmPqzmPLm\r\nsLwnMHnbnLMjGpZsjGGtpc\r\nggvJrNNTQgQrNvgqBqZCCjClWjGtWjCpGJFW\r\nTVdrqvVrTNTzBqQQzTRMfHbMwMbZMdMbHwRD\r\nbcfJQQJHsQPCpdpWdPbb\r\nRHjHDwZtrZmRDDtwtjRBVFdWVrrrBClldVphCF\r\nzDgwgNzjmDnMnzMMHncG\r\nvMHRvMhvHWRBRDHhRBwWvRBqLqbGwqnqnnNTbNqdNbbVVr\r\npslgcZszJltrsZcZgNnnqbSSTSSndbNbzS\r\ncZcgsZgZZgPgmcpfJtfttWBQvmFWjDQDhBmFjDHvFr\r\nbVbBvdTTVLbCgCznLJsJcwHPczfz\r\nNFcDphSDrFjGtZNZjplZGZFnzPHPrzHHzJMnnwfPsPsRJs\r\ncGtGljFmWdvqmVCV\r\nqSNbTvcvTGTvGcgtBNvcbdrdjrnjRnjRVHdDqHrRHj\r\nZZZZPLWPzPDCCsCRnRdwVFnjdwPVFP\r\nChlCLLZftfcBvfDv\r\ncRtfctVgmRclmBFGbbMBDDFPtD\r\nsvQZhHSHssjTvjpQjSSBBMJMJGDBpPbMzzpGzP\r\nZsvsCTWhCHhSwwjrwbndldlRnfRNmb\r\nPQdTgdGpRcTccCfj\r\nhHFLHlHBhBlmlDFzHrhhfZNZbfNZcVWNVVZRDjCC\r\nLFLLMHJHSBhBFGGnMMvsGtGGtj\r\nfwmVnVCDVqpNQqqb\r\nddBcZZWdvGWzBzsWvLvddlNHcHQPbQqqJQNNQHPHQT\r\nWgGvsMMzvgbntDhCmt\r\nJjwhFMmwjJwmCgTgSCSFlPLg\r\nWWbsbVtftBZWtnWtncbQvctTGLpLgCpzPPPlllpzlgPPTQ\r\nTBvnfBffWsfVtTvbZBTNjwjqddhMNqwRMMhdRMrq\r\nSllrbtTSQrSQrbrvvMvzFDsBsssWpWdWbGpGBWNWNW\r\nhhCfmmmjmPLCfmnPLfqPgqqNNBpjZBZQDNQdpWNpdBBsBp\r\nRhLfPhQLQfCRnHfqTHHrFJMrttTwTtzt\r\nBFrFBJMMJnnsNJBFCdLCnmvzbPdCmPnc\r\nLDLVHQRfDvdHdcCmcv\r\nllQDwqSVLwZLZSgsGZMNMgTjTMTr\r\nmrwdbqRhdCNGgZBHbH\r\njVTPMjvjpvMfTfQfPlpHHZNnNBHgZDGsGMnCsZ\r\nTLlfQpffQvvzhtNqztRFtzcm\r\nDDfvJZZPDHVPSPcSvcgcWCsWQcTTdhQTTh\r\ndMwpbdjRtrFhhTsTFQWqhC\r\nbGRdNpbzlvLfDfZlLZ\r\nbdPQdcpdbpjFqpQcQwqqhhNRhJvWRfrrWBsJrfwN\r\nmMtlZfmtnLZtSnGDlmGWRRhrWLhJsBRvgRWghh\r\nDnMGCtmCzfGMbjdQbVzpqcFH\r\njwnGggRBvvpBZCljCsCWrhhrsh\r\nFVMcFLqLMqcJfVtDqMJcHMHWCSblzzrWsdhSLlSzbrGCLz\r\nHQVFPDtDQDFFNTZpPgNnGgNn\r\nHNBHNqlqHJQBRNvdmZvmPdZZlpnT\r\nbDbbhDgSfzVVfnvPmfHmTZZd\r\njgzbwrhVsDgsDWLwJqqBMqcqHL\r\ntzNtJzsJVBHzbjbglCHc\r\nnfmnGnmPhntCgHvtvmCj\r\nMStTwrMTWrTdBZSNLZJNVQ\r\nNVjmwmVGGwGFHstwFHMhTh\r\npsRSzzscZscZpgQQzqQtBBHTTlThHHtTTh\r\nrCprbpZccggcrRzbbRRbscvVVWWvNfvVWnGDCWVNddmd\r\nrphfGDgtPtllrPlFlGrhGjnmnTnjcBsncBBVpTTBmc\r\nSqqZMJCLwgCwJgQRqqgZQNwdBBsBBHVBdTHNsnVNBTccnc\r\nMJqZZMbqgzRCSJZwPtFfGzWhrrfGttWl\r\ncSZqqcwbqVzqCbqVqVZPsvvDCDrffngvphggndhdGh\r\ntTNTMWJNQJHMNGSSprfdGnfdth\r\nWNRHWWMJSRWzswbczsVPRs\r\nHCgcSMhSMBGMdvGf\r\nRNQqbDQqFdRFdmTZfGtPZvtGlQffll\r\nmNpdNrRDbTNrmbpzmpWmbpWcswhcHcjhscSHjSgVHwHn\r\nMwgcFgwMMcscCbMFsMFCgMgPPLWPvptvBvPvtvvWmBBzwG\r\nnhQQjTJRVDdQJrPpmnGGBmvtGvLz\r\nHdJQdJHjrJQDBQjhQVQJhdJcqlFHcSqsNbCbCqCHFqCFgC\r\nJvTnvWtdJLbhJHbMwwHjcGHCwHwQGQ\r\nmqtmsllmfqVFwMwMrrPjmQrC\r\nlfztRZSlRDRVzfdpWnSvWhNdbnpp\r\nrSvrgggzHTNzrHtnptpmlDngZjWj\r\nMdMhqMhsfMSRcGqRsQQRctjjdDnjtjClCjjpZnDlnt\r\nBBMRsQRfRcscGqBfRRsBssPBLLzNLFPwvVFFPTLbbLwHHTvS\r\npCmCfdPFzmsFsDhFFDsttptpRtJjLnlJRtttHt\r\nZQwgWZgqJhTTRtgV\r\nGNqWNvcqqQQrMMWcQzDDsSzBDBSssSmhhr\r\n";
        }
    }
}